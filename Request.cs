namespace Yukky.Log {
    class Request {
        public FullLog log;
        public string appkey;
        public string appsecret;

        public Request (FullLog log, string appkey, string appsecret) {
            this.log = log;
            this.appkey = appkey;
            this.appsecret = appsecret;
        }
    }
}