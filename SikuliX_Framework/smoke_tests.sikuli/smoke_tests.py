from _lib import *

    
class SmokeTests(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
        
    def test_TC001_create_topic(self):
        ForumStart.StartBrowserChrome()

        wait(9)
        click(Comment.login_button)
        wait(5)
        username = "test_01_telerik_forum@mail.bg"
        password = "Testaccount01"
        

        if (exists(Comment.email_address_field)):
            click(Comment.email_address_field)
            paste(username)
            
    
            if (exists(Comment.suggest_username)):
                click(Comment.suggest_username)
                click(Comment.sign_in_button)
            else:    
                click(Comment.password_field)
                paste(password)
                
                click(Comment.sign_in_button)
                wait(10)
            
        text = "Created with Sikuli"
        click(Comment.new_topic_button)
        wait(3)
        click(Comment.topic_title)
        type(Generate.randomword(10) + " ")
        paste(text)
        

        click(Comment.text_area)
        title = (Generate.randomword(10))
        type(Generate.randomword(10))
        

        click(Comment.create_topic)
        wait(3)
        assert(exists(Comment.created_with_Sikuli_title))


############Testing comment functionalities############
###########Prerequisite - user is logged in############

    def test_TC059_create_comment(self):
        ForumStart.StartBrowserFirefox()
        Navigate.FindTopicInPage()
        assert(exists(Comment.topic))
        Navigate.FindCommentInTopic()
        wait(Comment.reply, 2)
        click(Comment.reply)
        type("Testing creation of a comment")
        click(Comment.reply)
        Navigate.GoBackInPage()


    def test_TC060_edit_comment(self):
        Navigate.FindTopicInPage()
        Navigate.FindCommentInTopic()
        click(Comment.edit)
        assert(exists(Comment.current_comment))
        click(Comment.current_comment)
        Navigate.DeleteText()
        type("Editing comment")
        click(Comment.save_edit)
        wait(5)
    
    def test_TC061_flag_comment(self):
        click(Comment.more_options)
        wait(2)
        click(Comment.flag_topic)
        assert(exists(Comment.flag_reason))
        click(Comment.flag_check)
        wait(Comment.flag_post,2)
        click(Comment.flag_post)
        assert(exists(Comment.flagged_spam))
        ForumStart.CloseBrowser()

if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(SmokeTests)
    
   
    outfile = open("Report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='SmokeTests Report' )
    runner.run(suite)
    outfile.close()

