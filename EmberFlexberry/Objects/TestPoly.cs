﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmberFlexberryDummy
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// TestPoly.
    /// </summary>
    // *** Start programmer edit section *** (TestPoly CustomAttributes)

    // *** End programmer edit section *** (TestPoly CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("TestPolyEdit", new string[] {
            "SelfPole as \'Self Pole\'",
            "Relation as \'Relation\'",
            "Relation.Pole as \'Pole\'"}, Hidden=new string[] {
            "Relation.Pole"})]
    [MasterViewDefineAttribute("TestPolyEdit", "Relation", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Pole")]
    [View("TestPolyList", new string[] {
            "SelfPole as \'SelfPole\'",
            "Relation",
            "Relation.Pole as \'Pole\'"}, Hidden=new string[] {
            "Relation.Pole"})]
    [MasterViewDefineAttribute("TestPolyList", "Relation", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Pole")]
    public class TestPoly : ICSSoft.STORMNET.DataObject
    {
        
        private string fSelfPole;
        
        private EmberFlexberryDummy.TestPolyBase fRelation;
        
        // *** Start programmer edit section *** (TestPoly CustomMembers)

        // *** End programmer edit section *** (TestPoly CustomMembers)

        
        /// <summary>
        /// SelfPole.
        /// </summary>
        // *** Start programmer edit section *** (TestPoly.SelfPole CustomAttributes)

        // *** End programmer edit section *** (TestPoly.SelfPole CustomAttributes)
        public virtual string SelfPole
        {
            get
            {
                // *** Start programmer edit section *** (TestPoly.SelfPole Get start)

                // *** End programmer edit section *** (TestPoly.SelfPole Get start)
                string result = this.fSelfPole;
                // *** Start programmer edit section *** (TestPoly.SelfPole Get end)

                // *** End programmer edit section *** (TestPoly.SelfPole Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TestPoly.SelfPole Set start)

                // *** End programmer edit section *** (TestPoly.SelfPole Set start)
                this.fSelfPole = value;
                // *** Start programmer edit section *** (TestPoly.SelfPole Set end)

                // *** End programmer edit section *** (TestPoly.SelfPole Set end)
            }
        }
        
        /// <summary>
        /// TestPoly.
        /// </summary>
        // *** Start programmer edit section *** (TestPoly.Relation CustomAttributes)

        // *** End programmer edit section *** (TestPoly.Relation CustomAttributes)
        [PropertyStorage("Relation")]
        [TypeUsage(new string[] {
                "EmberFlexberryDummy.TestPolyChild",
                "EmberFlexberryDummy.TestPolyAnotherChild"})]
        [NotNull()]
        public virtual EmberFlexberryDummy.TestPolyBase Relation
        {
            get
            {
                // *** Start programmer edit section *** (TestPoly.Relation Get start)

                // *** End programmer edit section *** (TestPoly.Relation Get start)
                EmberFlexberryDummy.TestPolyBase result = this.fRelation;
                // *** Start programmer edit section *** (TestPoly.Relation Get end)

                // *** End programmer edit section *** (TestPoly.Relation Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TestPoly.Relation Set start)

                // *** End programmer edit section *** (TestPoly.Relation Set start)
                this.fRelation = value;
                // *** Start programmer edit section *** (TestPoly.Relation Set end)

                // *** End programmer edit section *** (TestPoly.Relation Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// Представление формы редактирования класса-мастера для проверки полиморфных связей.
            /// </summary>
            public static ICSSoft.STORMNET.View TestPolyEdit
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("TestPolyEdit", typeof(EmberFlexberryDummy.TestPoly));
                }
            }
            
            /// <summary>
            /// Списковое представление класса-мастера для проверки полиморфных связей.
            /// </summary>
            public static ICSSoft.STORMNET.View TestPolyList
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("TestPolyList", typeof(EmberFlexberryDummy.TestPoly));
                }
            }
        }
    }
}