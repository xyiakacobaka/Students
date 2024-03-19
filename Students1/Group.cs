using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Group
{
    public int Id { get; set; }
    public string Name;
    public string name
    {
        get { return Name; }
        set
        {
            if (value == "ПИ-221" || value == "ПИ-222" || value == "ИТ-221" || value == "ИТ-222") { Name = value; }
            else value = "";
        }
    }

}

