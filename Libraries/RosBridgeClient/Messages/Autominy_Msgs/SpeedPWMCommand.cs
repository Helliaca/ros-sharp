using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Autominy
{
   public class Autominy_SpeedPWMCommand : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "autominy_msgs/SpeedPWMCommand";
        public Standard.Header header;
        public int value;

        public Autominy_SpeedPWMCommand()
        {
            header = new Standard.Header();
            value = 0;
        }
    }
}