using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Autominy
{
   public class Autominy_SpeedCommand : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "autominy_msgs/SpeedCommand";
        public Standard.Header header;
        public float value;

        public Autominy_SpeedCommand()
        {
            header = new Standard.Header();
            value = 0;
        }
    }
}