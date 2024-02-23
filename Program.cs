using System;

Random random = new Random();
int n;
string? answer;
string[,] ports = { { "22", "SSH"}, { "53", "DNS" }, { "22", "SFTP" }, { "20", "FTP (lower)" }, { "21", "FTP (higher)" }, { "69", "TFTP" }, { "23", "TELNET" }
, { "67", "DHCP - lower" }, { "68", "DHCP (higher)" }, { "80", "HTTP" }, { "443", "HTTPS" }, { "161", "SNMP (lower)" }, { "162", "SNMP (higher)" }, { "3389", "RDP" }, { "123", "NTP" }
, { "5060", "SIP" }, { "5061", "SIP" }, { "445", "SMB" }, { "25", "SMTP" }, { "587", "SMTP(TLS)" }, { "110", "POP/POP3" }, { "995", "POP3(TLS)" }, { "143", "IMAP" }
, { "993", "IMAP(SSL)" }, { "389", "LDAP" }, { "636", "LDAPS" }, { "514", "Syslog" }, { "1433", "SQL Server" }, { "1521", "SQLnet" }, { "3306", "MySQL" } };


do
{
    n = random.Next(0, 30);
    Console.WriteLine($"What is port number of {ports[n, 1]}?");
    answer = Console.ReadLine();
    try
    {
        check(answer!, ports[n, 0]);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
} while (answer != null);


static void check(string input, string ans)
{
    if (input == ans)
    {
        Console.WriteLine("Your answer was correct! Type any key for the next question");
    }
    else
        Console.WriteLine($"Incorrect. Correct answer is {ans}. Type any key for next question");
    Console.ReadLine();
}