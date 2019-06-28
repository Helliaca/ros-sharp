using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Autominy
{
   public class Autominy_SteeringAngle : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "autominy_msgs/SteeringAngle";
        public Standard.Header header;
        public float value;

        public Autominy_SteeringAngle()
        {
            header = new Standard.Header();
            value = 0;
        }
    }
}