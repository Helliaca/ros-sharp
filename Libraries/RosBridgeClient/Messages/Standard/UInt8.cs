using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Standard
{
    public class UInt8 : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "std_msgs/UInt8";
        public int data;

        public UInt8()
        {
            data = 0;
        }
    }
}
