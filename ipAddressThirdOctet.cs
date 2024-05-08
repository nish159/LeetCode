// Return the third octet and group the IP address  

string[] ipAddresses = { "192.168.1.2", "192.168.2.1", "192.168.1.1" };

// Call the SortIp method to sort IP addresses based on the third octet
Dictionary<string, List<string>> sortedIPs = SortIp(ipAddresses);

// Method to sort IP addresses based on the third octet
Dictionary<string, List<string>> SortIp(string[] ipAddressArray)
{
    // Create a dictionary to store IP addresses grouped by their third octet
    Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
    
    // Loop through the IP address array
    for (int i = 0; i < ipAddressArray.Length; i++)
    {
        // Get the third octet of the current IP address
        string thirdOctet = GetThirdOctet(ipAddressArray[i]);
        
        // Check if the dictionary already contains the third octet as a key
        if (dictionary.ContainsKey(thirdOctet))
        {
            // Add the current IP address to the list of IP addresses for this third octet
            dictionary[thirdOctet].Add(ipAddressArray[i]);
        }
        else
        {
            // Create a new list to store IP addresses for this third octet
            List<string> newList = new List<string>();
            newList.Add(ipAddressArray[i]);
            
            // Add the new key-value pair to the dictionary
            dictionary.Add(thirdOctet, newList);
        }
    }
    
    // Return the sorted dictionary
    return dictionary;
}

// Helper function to extract the third octet from an IP address
string GetThirdOctet(string ipAddress)
{
    // Split the IP address into octets based on the dot separator
    string[] octets = ipAddress.Split('.');
    
    // Return the third octet (index 2 in the array)
    return octets[2];
}
