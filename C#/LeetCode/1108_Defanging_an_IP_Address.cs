public class Solution {
    public string DefangIPaddr(string address) {
        string[] newAddresses = address.Split('.');
        string newPattern = "";
        
        foreach(string newAddress in newAddresses)
        {
            newPattern += $"{newAddress}[.]";
        }
        
        return newPattern.Substring(0, newPattern.Length - 3);
    }
}