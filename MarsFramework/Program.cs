using MarsFramework.Global;
using MarsFramework.Pages;
using MarsFramework.POM_Pages;
using MarsFramework.PROFILE_Pages;
using NUnit.Framework;
using RazorEngine.Compilation.ImpromptuInterface;
using System.Threading;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]



        class User : Global.Base
        {
            [Test]
            public void language()
            {
                //Start Report
                test = extent.StartTest("Language Addition");
                //Creating an Instance/Object of Avalibity_HOurs_EarnTarget
                PROFILE_Pages.Languages create = new PROFILE_Pages.Languages();

                //Add New language
                create.addlanguage();  //(Working Properly)
                create.ValidateAddLanguage();//( (Working Properly))

                //Update Language
                 create.UpdateLanguage();  //(Working Properly)
                 create.Validate_Update_language();

                //Delete Language
                 create.DeleteLanguage(); //(Working Properly)
                
                          

            }
            [Test]
            public void Skills()
            {
                //Start Report
                test = extent.StartTest("Skills Addition");
                //Creating an Instance/Object of Avalibity_HOurs_EarnTarget
                PROFILE_Pages.Skills create = new PROFILE_Pages.Skills();

                //Add New Skill
                create.AddNewskill(); //(Woking Properly)
                create.ValidateAddedSkill();

                //Update New Skill
                create.UpdateNewSkill();  //(Woking Properly)
                create.ValidateUpdateSkill();

                //Delete Skills
                create.DeleteSkill();     //(Working Properly)


            }

            [Test]
            public void Education()
            {
                //Start Report
                test = extent.StartTest("Education Addition");
                //Creating an Instance/Object of Avalibity_HOurs_EarnTarget
                PROFILE_Pages.Education create = new PROFILE_Pages.Education();

                //Add New Education
                create.AddNewEdctn();  //(Working Properly)
                create.ValidateAddEducation();

                //Update Education
                create.UpdateEducation();  //(Working Properly)
                create.ValidateUpdateEducation();

                //Delete Added Education
                create.DeleteEducation();  //(Working Properly)

                

                
                
            }
            [Test]
            public void Certification()
            {
                //Start Report
                test = extent.StartTest("Certification Addition");
                //Creating an Instance/Object of Avalibity_HOurs_EarnTarget

                PROFILE_Pages.Certification create = new PROFILE_Pages.Certification(GlobalDefinitions.driver);


                //Add New Certification
                create.AddNewCertification(); //(Working Properly)
                create.ValidateAddCertification();

                //Update Certification
                create.UpdateCertification();  //( working)
                create.ValidateUpdatedCertification();

                //Delete Added Certification
                create.DeleteCertification();
                
                


            }

            [Test]
            public void Avlblty_Hrs_ErnTrgt()
            {
                //Start Report
                test = extent.StartTest("Avlblty_Hrs_ErnTrgt");

                //Creating an Instance/Object of Avalibity_HOurs_EarnTarget
                PROFILE_Pages.Avlblty_Hrs_ErnTrgt create = new PROFILE_Pages.Avlblty_Hrs_ErnTrgt();

                //Add Profile, Availability ,  Hours , earn Target
                create.AddAvailability();

                //Add Profile, Availability ,  Hours , earn Target
                create.AddHours();

                //Add Profile, Availability ,  Hours , earn Target
                create.AddEarnTarget();
            }

            [Test]
            public void DescriptionAdd()
            {
                //Start Report
                test = extent.StartTest("Description");

                //Creating an Instance/Object of Avalibity_HOurs_EarnTarget
                PROFILE_Pages.Description create = new PROFILE_Pages.Description(GlobalDefinitions.driver);

                //Add Description
                create.AddDescription();  //(Working Properly)
            }
            [Test]
            public void ChngPsswrd()
            {
                //Start Report
                test = extent.StartTest("Change Password");

                //Creating an Instance/Object of Avalibity_HOurs_EarnTarget

                ChangePassword create = new ChangePassword();
                create.Password_Change();
                
                               

                
            }

             [Test]
            public void SrchSkill()
            {
                //Start Report
                test = extent.StartTest("Search Skill");

                SearchSkills create = new SearchSkills();
                create.SkillSearch_By_AllCategories();
               // create.SkillSearch_By_SubCateogory();
              //  create.Validation_Search_By_Filter();
               // create.Search_By_Filter();


            }


            [Test]
            public void ManageListing()
            {
                //start Report
                test = extent.StartTest("Manage Listing");

                //Creating an Instance /Object of mange listing 
                Manage_Listing_Pages.ManageListings CreateNew = new Manage_Listing_Pages.ManageListings();

                //Edit Mangelisting
                CreateNew.EditManageListing();  

                //Delete ManageListing
                 CreateNew.DeleteManageListing();


            }
          
            [Test]
            public void ShareSkillTest()
            {
               // Start Report
               test = extent.StartTest("ShareSkillTest");


                //Creating a new Instance of Shareskill page
                ShareSkill add = new ShareSkill();

                //Adding new share skill
                add.ShareSkillAdd();

            }

       
            [Test]
            public void SearchSkillOperation()
            {
                // Start Report
                test = extent.StartTest("SearchSkillOperation");

                //Creating an Instance of Search Skill Page
                SearchSkills find = new SearchSkills();

                //Find SkillSearch_By_All_Categories
                find.SkillSearch_By_AllCategories();  //(working properly)

                //Find SkillSearch_By_Sub_Categories
                find.SkillSearch_By_SubCateogory();  //(Working Properly)

                //Find SkillSearch_By_Filters
                 find.Search_By_Filter();  //(Working Properly)

                //Validate Search By Filters
                find.Validation_Search_By_Filter();  //(Working Properly)

            }

             
        }
    }
    
    
}