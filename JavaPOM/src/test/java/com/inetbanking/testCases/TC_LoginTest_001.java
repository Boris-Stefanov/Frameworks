package com.inetbanking.testCases;

import com.inetbanking.pageObjects.LoginPage;
import com.inetbanking.testCases.BaseClass;
import org.apache.log4j.BasicConfigurator;
import org.testng.Assert;
import org.testng.annotations.Test;

import java.io.IOException;

public class TC_LoginTest_001 extends BaseClass {

    @Test
    public void loginTest() throws IOException {

        //BasicConfigurator.configure();
        logger.info("URL is opened");

        System.out.println(driver.getTitle());
        LoginPage lp =new LoginPage(driver);

        lp.setUserName(username);
        logger.info("Entered username");

        lp.setPassword(password);
        logger.info("Entered password");
        lp.clickSubmit();
        System.out.println(driver.getTitle());

        //Assert.assertEquals(driver.getTitle(), "Guru99 Bank Manager HomePage");

        if (driver.getTitle().equals("Guru99 Bank Manager HomePage")){
            Assert.assertTrue(true);
            logger.info("Login test passed");
        } else {
            captureScreen(driver, "loginTest");
            Assert.assertTrue(false);
            logger.info("Login test failed");
        }
    }


}
