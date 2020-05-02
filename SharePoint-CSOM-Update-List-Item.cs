using System;  
using Microsoft.SharePoint.Client;  
  
namespace TestApplication  
{  

  class TestUpdateListItem
  {  

    static void Main()  
    { 
        string siteUrl = "http://spsite/sites/sitecollname"; 

        ClientContext clientContext = new ClientContext(siteUrl);  

        List oList = clientContext.Web.Lists.GetByTitle("TestList");  

        ListItem oListItem = oList.Items.GetById(4);  

        oListItem["Title"] = "Updated text value";  

        oListItem.Update();  

        clientContext.ExecuteQuery();
    }
  }  
}   