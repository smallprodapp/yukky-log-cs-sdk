using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Yukky.Log {
    public class YukkyLog {
        private static string appkey;
        private static string appsecret;
        private static bool debug;
        private static HttpClient client;

        public static void Init (string appkey, string appsecret, bool debug = false) {
            YukkyLog.appkey = appkey;
            YukkyLog.appsecret = appsecret;
            YukkyLog.debug = debug;
            client = new HttpClient ();
            client.BaseAddress = new Uri ("https://api.yukkyapp.com/");
            client.DefaultRequestHeaders.Accept.Clear ();
            client.DefaultRequestHeaders.Accept.Add (new MediaTypeWithQualityHeaderValue ("application/json"));
        }

        private static async Task<HttpResponseMessage> Request (FullLog log) {
            Request req = new Request (log, appkey, appsecret);
            HttpResponseMessage res = await client.PostAsJsonAsync ("log", req);
            return res;
        }

        public static async Task<HttpResponseMessage> Error (Log log) {
            try {
                FullLog full = new FullLog (log, "error");
                return await Request (full);
            } catch (Exception ex) {
                if (debug) {
                    Console.WriteLine (ex);
                }
                return null;
            }
        }

        public static async Task<HttpResponseMessage> Warning (Log log) {
            try {
                FullLog full = new FullLog (log, "warning");
                return await Request (full);
            } catch (Exception ex) {
                if (debug) {
                    Console.WriteLine (ex);
                }
                return null;
            }
        }

        public static async Task<HttpResponseMessage> Info (Log log) {
            try {
                FullLog full = new FullLog (log, "info");
                return await Request (full);
            } catch (Exception ex) {
                if (debug) {
                    Console.WriteLine (ex);
                }
                return null;
            }
        }

        public static async Task<HttpResponseMessage> Custom (FullLog log) {
            try {
                return await Request (log);
            } catch (Exception ex) {
                if (debug) {
                    Console.WriteLine (ex);
                }
                return null;
            }
        }
    }
}