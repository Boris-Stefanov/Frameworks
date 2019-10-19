package com.inetbanking.pageObjects;

import com.inetbanking.testCases.BaseClass;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.CacheLookup;
import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.support.PageFactory;

public class AddCustomerPage extends BaseClass {

    WebDriver driver;

    public AddCustomerPage(WebDriver driver){
        this.driver = driver;
        PageFactory.initElements(driver, this);
    }

    @FindBy(linkText = "New Customer")
    @CacheLookup
    WebElement buttonAddNewCustomer;

    @FindBy(name = "name")
    @CacheLookup
    WebElement fieldCustomerName;

    @CacheLookup
    @FindBy(name = "rad1")
    WebElement radioGender;

    @FindBy(id = "dob")
    @CacheLookup
    WebElement fieldDateOfBirth;

    @FindBy(name = "addr")
    @CacheLookup
    WebElement fieldAddress;

    @CacheLookup
    @FindBy(name = "city")
    WebElement fieldCity;

    @CacheLookup
    @FindBy(name = "state")
    WebElement fieldState;

    @CacheLookup
    @FindBy(name = "pinno")
    WebElement fieldPIN;

    @CacheLookup
    @FindBy(name = "telephoneno")
    WebElement fieldGSM;

    @CacheLookup
    @FindBy(name = "emailid")
    WebElement fieldEmail;

    @CacheLookup
    @FindBy(name = "password")
    WebElement fieldPassword;

    @CacheLookup
    @FindBy(name = "sub")
    WebElement buttonSubmit;

    public void clickAddNewCustomer(){
        buttonAddNewCustomer.click();
    }

    public void customerName(String name){
        fieldCustomerName.sendKeys(name);
    }

    public void customerDate(String mm, String dd, String yy){
        fieldDateOfBirth.sendKeys(mm);
        fieldDateOfBirth.sendKeys(dd);
        fieldDateOfBirth.sendKeys(yy);
    }

    public void customerPIN(int pin){
        fieldPIN.sendKeys(String.valueOf(pin));
    }

    public void customerGSM(String gsm){
        fieldGSM.sendKeys(gsm);
    }

    public void customerEmail(String email){
        fieldEmail.sendKeys(email);
    }

    public void customerPassword(String pass){
        fieldPassword.sendKeys(pass);
    }

    public void clickSubmitButton(){
        buttonSubmit.click();
    }

    public void customerCity(String city){
        fieldCity.sendKeys(city);
    }

    public void customerState(String state){
        fieldState.sendKeys(state);
    }

    public void customerAddress(String address){
        fieldAddress.sendKeys(address);
    }

    public void customerGender(String gender){
        radioGender.click();
    }


}
