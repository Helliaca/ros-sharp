using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Autominy
{
   public class Autominy_Speed : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "autominy_msgs/Speed";
        public Standard.Header header;
        public float value;

        public Autominy_Speed()
        {
            header = new Standard.Header();
            value = 0;
        }
    }
}