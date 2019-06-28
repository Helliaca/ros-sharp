using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Standard
{
    public class Int8 : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "std_msgs/Int8";
        public int data;

        public Int8()
        {
            data = 0;
        }
    }
}
