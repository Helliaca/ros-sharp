using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Autominy
{
   public class Autominy_Tick : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "autominy_msgs/Tick";
        public Standard.Header header;
        public int value;

        public Autominy_Tick()
        {
            header = new Standard.Header();
            value = 0;
        }
    }
}