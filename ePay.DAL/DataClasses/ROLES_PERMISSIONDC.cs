
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 3/19/2015 3:47:53 PM
// Last Updated on: 

using System;
namespace EPay.DataClasses
{

    public class ROLES_PERMISSIONDC : AbstractDataClass
    {
        public int ROLE_ID { get; set; }
        public int SCREEN_ID { get; set; }
        public int PERMISSION_TYPE_ID { get; set; }
        public string PERMISSION_TYPE { get; set; }
        public string PERMISSION_TITLE { get; set; }
        public string GENERAL_EDIT_ACCESS_TYPE { get; set; }
        public bool VIEW_ACCESS_GENERAL { get; set; }
        public bool EDIT_ACCESS { get; set; }
        public bool IsDirty { get; set; }
    }
}