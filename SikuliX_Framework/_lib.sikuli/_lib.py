from sikuli import *
import unittest
import iHTMLTestRunner.iHTMLTestRunner as HTMLTestRunner
from _uimap import *

import random
import string


class ForumStart:
    @classmethod
    def StartBrowserChrome(self):
        #type('r', KeyModifier.WIN)
        click(Comment.search)
        wait(4)
        

        chrome_broswer = "chrome"        
        paste(chrome_broswer)
        wait(5)
        
        rightClick(Comment.chrome)
        click(Comment.incognito_window)
        wait(15)
        url = "https://schoolforum.telerikacademy.com/"
        paste(url)
        type(Key.ENTER)


        type(Key.UP,KeyModifier.WIN)

        wait(2)

    @classmethod
    def StartBrowserFirefox(self):
        type('r', KeyModifier.WIN)
        wait(2)
        type('firefox')
        wait(2)
        type(Key.ENTER)
        wait(5)
        type('https://schoolforum.telerikacademy.com/' + Key.ENTER)
        wait(5)


    @classmethod
    def CloseBrowser(self):
        type(Key.F4, KeyModifier.ALT)


class Navigate:
    @classmethod
    def GoBackInPage(self):
        type(Key.LEFT, KeyModifier.ALT)
        wait(2)

    @classmethod
    def DeleteText(self):
        doubleClick(Comment.current_comment)
        type("a", KeyModifier.CTRL)
        wait(2)
        type(Key.BACKSPACE)
        wait(5)

    @classmethod
    def FindTopicInPage(self):
        click(Search.search_button)
        wait(Search.search_field, 2)
        type("test create new topic")
        type(Key.ENTER)
        wait(Comment.find_topic_in_forum, 5)
        click(Comment.find_topic_in_forum)
        wait(5)

    @classmethod
    def FindCommentInTopic(self):
        if not exists(Comment.comment):
            type(Key.PAGE_DOWN*2)
            wait(3)

        else:
            type(Key.PAGE_DOWN*2)
            wait(3)

class Generate:
    @classmethod
    def randomword(self,length):
        letters = string.ascii_lowercase
        return ''.join(random.choice(letters) for i in range(length))
