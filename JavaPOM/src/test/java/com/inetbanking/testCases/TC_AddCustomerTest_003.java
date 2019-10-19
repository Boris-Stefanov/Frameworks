package com.inetbanking.testCases;

import com.inetbanking.pageObjects.AddCustomerPage;
import com.inetbanking.pageObjects.LoginPage;
import org.testng.Assert;
import org.testng.annotations.Test;

import java.io.IOException;

public class TC_AddCustomerTest_003 extends BaseClass {

    @Test
    public void addNewCustomer() throws IOException, InterruptedException {

        LoginPage lp = new LoginPage(driver);

        lp.setUserName(username);
        lp.setPassword(password);
        lp.clickSubmit();

        AddCustomerPage addCustomer = new AddCustomerPage(driver);

        String email = randomString() + "@skynet.com";

        addCustomer.clickAddNewCustomer();
        addCustomer.customerName("John");
        addCustomer.customerGender("male");
        addCustomer.customerDate("10","15","1985");
        addCustomer.customerAddress("USA");
        addCustomer.customerCity("Los Angeles");
        addCustomer.customerState("California");
        addCustomer.customerPIN(123456);
        addCustomer.customerGSM("988343432");
        addCustomer.customerEmail(email);
        addCustomer.customerPassword("skynetT800");
        addCustomer.clickSubmitButton();

        boolean result = driver.getPageSource().contains("Customer Registered Successfully!!!");

        if(result == true){
            logger.info("customer added - pass");
            Assert.assertTrue(true);
        } else {
            logger.info("customer added - fail");
            captureScreen(driver, "add customer test");
            Assert.assertTrue(false);
        }
    }

}
