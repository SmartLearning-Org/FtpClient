using System.Net;

FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://inverter.westeurope.cloudapp.azure.com");
request.Method = WebRequestMethods.Ftp.ListDirectory;

Console.WriteLine("Indtast brugernavn");
string user = Console.ReadLine();

Console.WriteLine("Indtast adgangskode");
string password = Console.ReadLine();

request.Credentials = new NetworkCredential(user, password);

FtpWebResponse response = (FtpWebResponse)request.GetResponse();
var stream = response.GetResponseStream();
var reader = new StreamReader(stream);

Console.WriteLine(reader.ReadToEnd());

reader.Close();
response.Close();