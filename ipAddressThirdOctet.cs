// Return the third octet and group the IP address  

string[] ipaddress = { "192.168.1.2", "192.168.2.1", "192.168.1.1" };

SortIp(ipaddressAray);

Dictionary<string, List<string>> SortIp(string[] ipaddressArray) 
{
// create a map/dictionary to store the values
    Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
    
    // loop through the array
    for (int i = 0; i < ipaddressArray.Length; i++)
    {
        // look for the third octet and store value
        var thirdOctet = GetThirdOctet(ipaddressArray[i]);
        // var thirdOctet = ipaddressArray[i].Split('.')[2];
        
        // "1" => ["192.168.1.1", "192.168.1.2"]
        // "2" => ["192.168.2.1"]
        
        // if dictionary already contains third octet add ip address value otherwise
        // create a new array and store the new key and value
        if (dictionary.ContainsKey(thirdOctet))
        {
            dictionary[thirdOctet].Add(ipaddressArray[i]);
        }
        else
        {
        // create a new list to store new key values
            List<string> newArr = new List<string>();
            newArr.Add(ipaddressArray[i]);
            
            // add the key, value pairs
            dictionary.Add(thirdOctet, newArr);
        }
    }
    return dictionary;
}

// helper function
string GetThirdOctet(string ipaddress)
{
    string[] octets = ipaddress.Split('.');
    // {"192", "168", "1", "2"};
    return octets;
}
