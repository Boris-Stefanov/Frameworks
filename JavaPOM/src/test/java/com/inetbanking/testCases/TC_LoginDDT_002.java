package com.inetbanking.testCases;

import com.inetbanking.pageObjects.LoginPage;
import com.inetbanking.utilities.XLUtils;
import org.openqa.selenium.NoAlertPresentException;
import org.testng.Assert;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import java.io.IOException;
import java.util.logging.Logger;

public class TC_LoginDDT_002 extends BaseClass {

    @Test(dataProvider = "LoginData")
    public void loginDDT(String username, String password){

        LoginPage lp =new LoginPage(driver);

        lp.setUserName(username);
        logger.info("username provided");
        lp.setPassword(password);
        logger.info("password provided");
        lp.clickSubmit();

        if (lp.isAlertPresent() == true){
            driver.switchTo().alert().accept();
            driver.switchTo().defaultContent();
            logger.info("login failed");
            Assert.assertTrue(false);
        } else {
            logger.info("login passed");
            Assert.assertTrue(true);
            lp.clickLogOut();
            driver.switchTo().alert().accept(); //close logout alert
            driver.switchTo().defaultContent();
        }
    }

}
