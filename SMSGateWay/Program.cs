using SMSGateWay;

string BaseApi = "https://api.sms.net.bd/sendsms";
string apiKey = "Api-Key";
string messageBody = "Message";
string number2 = "Number That I want to send to";

SendSms sendSms = new();

var response = await sendSms.SendSmsAsync(BaseApi, apiKey, messageBody, number2);
Console.WriteLine(response.ToString());