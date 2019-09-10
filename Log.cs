namespace Yukky.Log {
    public class Log {
        public string name;
        public string[] tags;
        public string desc;
        public object infos;

        public Log (string name, string[] tags, string desc, object infos) {
            this.name = name;
            this.tags = tags;
            this.desc = desc;
            this.infos = infos;
        }
    }
}