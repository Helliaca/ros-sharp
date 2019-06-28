using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Autominy
{
   public class Autominy_Voltage : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "autominy_msgs/Voltage";
        public Standard.Header header;
        public float value;

        public Autominy_Voltage()
        {
            header = new Standard.Header();
            value = 0;
        }
    }
}