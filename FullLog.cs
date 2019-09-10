namespace Yukky.Log {
    public class FullLog : Log {
        public string type;

        public FullLog (string name, string[] tags, string desc, object infos, string type) : base (name, tags, desc, infos) {
            this.type = type;
        }

        public FullLog (Log log, string type) : base (log.name, log.tags, log.desc, log.infos) {
            this.type = type;
        }
    }
}