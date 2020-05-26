jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "Employee.feature",
      "Feature": {
        "Name": "Employee",
        "Description": "Responsible for verfiying Benefits, Create Employee,\r\nDelete employee and check if the functionality works",
        "FeatureElements": [
          {
            "Name": "Create Employee with all details",
            "Slug": "create-employee-with-all-details",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I have navigated to the application",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I see application opened",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I click login link",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter UserName and Password",
                "TableArgument": {
                  "HeaderRow": [
                    "UserName",
                    "Password"
                  ],
                  "DataRows": [
                    [
                      "admin",
                      "password"
                    ]
                  ]
                },
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I click login button",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I click employeeList link",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I click createnew button",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I enter following details",
                "TableArgument": {
                  "HeaderRow": [
                    "Name",
                    "Salary",
                    "DurationWorked",
                    "Grade",
                    "Email"
                  ],
                  "DataRows": [
                    [
                      "AutoUser",
                      "5000",
                      "40",
                      "1",
                      "autouser@maciejwolejszo.pl"
                    ]
                  ]
                },
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I click create button",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@smoke"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false,
              "WasProvided": false
            }
          }
        ],
        "Background": {
          "Name": "",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I Delete employee 'AutoUser' before I start running test",
              "StepComments": [],
              "AfterLastStepComments": []
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false,
            "WasProvided": false
          }
        },
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false,
          "WasProvided": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false,
        "WasProvided": false
      }
    },
    {
      "RelativeFolder": "Login.feature",
      "Feature": {
        "Name": "Login",
        "Description": "Check if the login functionality is working\r\nas expected with different permutations and \r\ncombinations of data",
        "FeatureElements": [
          {
            "Name": "Check Login with correct username and password",
            "Slug": "check-login-with-correct-username-and-password",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I have navigated to the application",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I see application opened",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I click login link",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter UserName and Password",
                "TableArgument": {
                  "HeaderRow": [
                    "UserName",
                    "Password"
                  ],
                  "DataRows": [
                    [
                      "admin",
                      "password"
                    ]
                  ]
                },
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I click login button",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the username with hello",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@smoke",
              "@positive"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false,
              "WasProvided": false
            }
          }
        ],
        "Background": {
          "Name": "",
          "Description": "",
          "Steps": [],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false,
            "WasProvided": false
          }
        },
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false,
          "WasProvided": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false,
        "WasProvided": false
      }
    }
  ],
  "Summary": {
    "Tags": [
      {
        "Tag": "@smoke",
        "Total": 2,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 2
      },
      {
        "Tag": "@positive",
        "Total": 1,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 1
      }
    ],
    "Folders": [
      {
        "Folder": "Employee.feature",
        "Total": 1,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 1
      },
      {
        "Folder": "Login.feature",
        "Total": 1,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 1
      }
    ],
    "NotTestedFolders": [
      {
        "Folder": "Employee.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "Login.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Scenarios": {
      "Total": 2,
      "Passing": 0,
      "Failing": 0,
      "Inconclusive": 2
    },
    "Features": {
      "Total": 2,
      "Passing": 0,
      "Failing": 0,
      "Inconclusive": 2
    }
  },
  "Configuration": {
    "SutName": "EmployeeAppTest",
    "SutVersion": "1.0",
    "GeneratedOn": "12 maja 2020 12:29:38"
  }
});