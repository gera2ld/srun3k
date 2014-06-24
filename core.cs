/*
 * Created by SharpDevelop.
 * User: Gerald
 * Date: 2013/11/8
 * Time: 22:18
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;

namespace SRun3KStupid
{
	/// <summary>
	/// Core
	/// </summary>
	public class SRun3KCore
	{
		public SRun3KCore(object parent) {
			this.parent=parent;
		}
		public bool setServer(string host) {
			try {
				iphost=IPAddress.Parse(host);
			} catch {
				this.host=null;
				return false;
			}
			this.host=host;
			server=new IPEndPoint(iphost,port);
			return true;
		}
		public bool setServer(string host,int port) {
			this.port=port;
			return setServer(host);
		}
		public void setMAC(string mac) {
			this.mac=mac;
		}
		public bool isLoggedIn() {
			return uid>0;
		}
		public void logIn(string usr,string pwd) {
			if(string.IsNullOrEmpty(host)) callback("Please set host first.",0);
			else if(string.IsNullOrEmpty(mac)) callback("Please set MAC address first.",0);
			else {
				Thread t=new Thread(new ParameterizedThreadStart(_logIn));
				t.IsBackground=true;
				t.Start(new string[]{usr,pwd});
			}
		}
		public void logOut() {
			Thread t=new Thread(new ThreadStart(_logOut));
			t.IsBackground=true;
			t.Start();
		}
		
		const string sr_ua="Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.1 (KHTML, like Gecko) Chrome/21.0.1180.89 Safari/537.1 SRun3K Client_W115S0B20131021A-SRun3K";
		DateTime basetime=new DateTime(1970,1,1);
		string host=null,mac=null;
		int port=3335;
		IPAddress iphost;
		IPEndPoint server;
		long now,diff=0,uid=0;
		bool keeping=false;
		object parent;
		Stream post(string url,byte[] data) {
			HttpWebRequest req=(HttpWebRequest)WebRequest.Create(url);
			req.UserAgent=sr_ua;
			req.Method="POST";
			req.ContentType="application/x-www-form-urlencoded";
			req.Proxy=null;
			Stream st=req.GetRequestStream();
			st.Write(data,0,data.Length);
			st.Close();
			HttpWebResponse res=(HttpWebResponse)req.GetResponse();
			st=res.GetResponseStream();
			return st;
		}
		Stream post(string url,string data) {
			byte[] bdata=Encoding.UTF8.GetBytes(data);
			return post(url,bdata);
		}
		string postData(string url,string data){
			Stream st=post(url,data);
			StreamReader sr=new StreamReader(st);
			string r=sr.ReadToEnd();
			return r;
		}
		void callback(string message,int window) {
			Type t=parent.GetType();
			MethodInfo m=t.GetMethod("callback");
			m.Invoke(parent,new object[]{message,window});
		}
		string encode(string code, string key) {
			byte[] pcode=Encoding.UTF8.GetBytes(code),pkey=Encoding.UTF8.GetBytes(key);
			int lcode=pcode.Length,mkey=pkey.Length-1,m=mkey,l=0;
			byte[] penc=new byte[lcode*2];
			foreach (byte c in pcode) {
				int i=Convert.ToInt32(c)^pkey[m];
				int j=(15&i>>4)+99,k=(i&15)+54;
				penc[l++]=Convert.ToByte(m%2>0?k:j);
				penc[l++]=Convert.ToByte(m%2>0?j:k);
				if(--m<0) m=mkey;
			}
			return Encoding.UTF8.GetString(penc);
		}
		string logInOnce(string usr,string pwd){
			now=(DateTime.UtcNow.Ticks-basetime.Ticks)/10000000;
			long t=now-diff;
			string g,key=(t/60).ToString();
			pwd=encode(pwd,key);mac=encode(mac,key);
			pwd=System.Uri.EscapeDataString(pwd);
			mac=System.Uri.EscapeDataString(mac);
			try{
				g=postData(String.Format("http://{0}/cgi-bin/do_login",host),
			               String.Format("username={0}&password={1}&drop=0&type=2&n=100&mac={2}",usr,pwd,mac));
			}catch(WebException){
				g="Net error.@";
			}catch(Exception e){
				g=e.ToString()+"@";
			}
			return g;
		}
		bool keepAlive(){
			Socket s=new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
			byte[] b=BitConverter.GetBytes(uid),data=new byte[1024];
			s.SendTo(b,server);
			IPEndPoint ip=new IPEndPoint(IPAddress.Any,0);
			EndPoint e=(EndPoint)ip;
			s.SetSocketOption(SocketOptionLevel.Socket,SocketOptionName.ReceiveTimeout,1000);
			try{
				int l=s.ReceiveFrom(data,ref e);
				if(l>8) {
					long d=BitConverter.ToInt64(data,0);
					return d==uid;
				}
			}catch{
			}finally{
				s.Close();
			}
			return false;
		}
		void _logIn(object op) {
			string[] p=(string[])op;
			string usr=p[0],pwd=p[1];
			// Try logging in
			string g=logInOnce(usr,pwd);
			string[] r=g.Split('@');
			int t;
			if(r.Length==2) {
				int.TryParse(r[1],out t);
				if(t>0) {
					diff=now-t;
					g=logInOnce(usr,pwd);
					r=g.Split('@');
				}
			}
			t=0;	// no action for window
			if(r.Length==2) {
				g=r[0];	// Error occurred
			} else {
				r=g.Split(',');
				if(r.Length==5) {
					long.TryParse(r[0],out uid);
					if(uid>0) {
						g="Logged in successfully.";
						t=1;	// hide window
					}
				}
			}
			callback(g,t);
			// Keep alive
			if(keeping||uid<=0) return;
			keeping=true;
			int delay=60000,error=0;
			while(uid>0) {
				Thread.Sleep(delay);
				if(keepAlive()) {	// Kept alive
					if(error>0) {
						delay=60000;
						error=0;
					}
				} else {	// Error occurred
					if(error==0) delay=10000;
					if(++error>=6) {	// Failed keeping alive
						uid=-1;
						callback("Error keeping alive, connection closed.",2);
					}
				}
			}
			keeping=false;
		}
		void _logOut() {
			if(uid>0) {
				string g;
				try{
					g=postData(String.Format("http://{0}/cgi-bin/do_logout",host),
					           String.Format("uid={0}",uid));
				}catch(Exception e){
					g=e.ToString();
				}
				if(g=="logout_ok") {
					uid=-1;
					g="Logged out successfully.";
				}
				callback(g,0);
			}
		}
	}
	
	public class Config {
		public Config() {
			filename=getFullPath("SRun3K.conf");
			try {
				loadConf();
			} catch {
				
			}
		}
		public string getConfString(string key,string def) {
			if(data.ContainsKey(key)) return data[key];
			else {
				if(def!=null) setConfString(key,def);
				return def;
			}
		}
		public string getConfString(string key) {
			return getConfString(key,null);
		}
		public bool getConfBool(string key,bool def) {
			if(data.ContainsKey(key)) return data[key]=="1";
			else {
				if(def) setConfBool(key,def);
				return def;
			}
		}
		public bool getConfBool(string key) {
			return getConfBool(key,false);
		}
		public void setConfString(string key,string val) {
			data[key]=val;
			changed=true;
		}
		public void setConfBool(string key,bool val) {
			setConfString(key,val?"1":"0");
		}
		public void save() {
			if(changed) dumpConf();
		}
		string filename;
		Dictionary<string,string> data=new Dictionary<string, string>();
		bool changed=false;
		string getFullPath(string f) {
			if(File.Exists(f)) return f;
			string a=Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),f);
			if(File.Exists(a)) return a; // %AppData%\{f} or ~/.config/{f}
			return Path.Combine(System.Windows.Forms.Application.StartupPath,f);
		}
		void loadConf() {
			StreamReader sr=new StreamReader(filename,Encoding.UTF8);
			string s=sr.ReadToEnd();
			sr.Close();
			try {
				s=Encoding.UTF8.GetString(Convert.FromBase64String(s));
			} catch {
				return;
			}
			string[] lines=s.Split('\n');
			foreach (string line in lines) {
				string[] args=line.Trim().Split(new char[]{'='},2);
				if(args.Length==2) data[args[0]]=args[1];
			}
		}
		void dumpConf() {
			string[] buf=new String[data.Count];
			int i=0;
			foreach (KeyValuePair<string,string> kv in data) {
				buf[i++]=string.Format("{0}={1}",kv.Key,kv.Value);
			}
			string d=string.Join("\n",buf);
			byte[] bytes=Encoding.UTF8.GetBytes(d);
			StreamWriter sw=new StreamWriter(filename,false,Encoding.UTF8);
			sw.Write(Convert.ToBase64String(bytes));
			sw.Close();
		}
	}
}
