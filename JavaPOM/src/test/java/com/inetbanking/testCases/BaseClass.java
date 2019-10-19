package com.inetbanking.testCases;

import com.inetbanking.utilities.ReadConfig;
import com.inetbanking.utilities.XLUtils;
import org.apache.commons.io.FileUtils;
import org.apache.commons.lang3.RandomStringUtils;
import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;
import org.openqa.selenium.OutputType;
import org.openqa.selenium.TakesScreenshot;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.firefox.FirefoxDriver;
import org.testng.annotations.AfterClass;
import org.testng.annotations.BeforeClass;
import org.testng.annotations.DataProvider;
import org.testng.annotations.Parameters;

import java.io.File;
import java.io.IOException;
import java.util.concurrent.TimeUnit;

public class BaseClass {

    ReadConfig readconfig = new ReadConfig();

    public String baseURL = readconfig.getApplicationURL();
    public String username = readconfig.getUserName();
    public String password = readconfig.getPassword();

    public static WebDriver driver;
    public static Logger logger;

    @Parameters("browser")
    @BeforeClass
    public void setUp(String br){

        logger = Logger.getLogger("ebanking");
        PropertyConfigurator.configure("log4j.properties");

        if (br.equals("chrome")){
            System.setProperty("webdriver.chrome.driver", readconfig.getChromePath());
            driver = new ChromeDriver();
        } else if (br.equals("firefox")){
            System.setProperty("webdriver.gecko.driver", readconfig.getFireFoxPath());
            driver = new FirefoxDriver();
        } else if (br.equals("edge")){
            System.setProperty("webdriver.edge.driver", readconfig.getEdgePath());
            driver = new EdgeDriver();
        }

        driver.manage().window().maximize();
        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
        driver.get(baseURL);
    }

    @AfterClass
    public void teardown(){
        driver.quit();
    }

    public void captureScreen(WebDriver driver, String tname) throws IOException {

        TakesScreenshot ts = (TakesScreenshot) driver;
        File source = ts.getScreenshotAs(OutputType.FILE);
        File target = new File(System.getProperty("user.dir") + "/Screenshots/" + tname + ".png");
        FileUtils.copyFile(source, target);
        System.out.println("Screenshot taken");
    }

    @DataProvider(name = "LoginData")
    public Object[][] getData() throws IOException {
        String path = System.getProperty("user.dir") + "/src/test/java/com/inetbanking/testData/LoginData.xlsx";
        int rownum = XLUtils.getRowCount(path, "Sheet1");
        int colcount = XLUtils.getCellCount(path, "Sheet1", 1);

        String loginData[][] = new String[rownum][colcount];

        for (int i = 1; i <= rownum ; i++) {
            for (int j = 0; j < colcount; j++) {
                loginData[i-1][j] = XLUtils.getCellData(path, "Sheet1", i,j);
            }
        }
        return loginData;
    }

    public String randomString(){
        String generatedString = RandomStringUtils.randomAlphabetic(8);
        return generatedString;
    }

    public String randomNumber(){
        String generatedNumber = RandomStringUtils.randomNumeric(4);
        return generatedNumber;
    }

}
