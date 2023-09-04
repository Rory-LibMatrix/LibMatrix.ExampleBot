using Microsoft.Extensions.Configuration;

namespace LibMatrix.ExampleBot.Bot; 

public class MRUBotConfiguration {
    public MRUBotConfiguration(IConfiguration config) {
        config.GetRequiredSection("Bot").Bind(this);
    }
    public string Homeserver { get; set; } = "";
    public string AccessToken { get; set; } = "";
    public string Prefix { get; set; }
}