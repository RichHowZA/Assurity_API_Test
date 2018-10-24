# Betway
A good automation framework:
## 1. Must be Modular
The more modular the framework, the easier maintenance will be. When code is shared between multiple testcases and there is a change to the system under test, the automater would just need to make their changes in one place and all the scripts will be up to date.

It should have a Function Library to contain all functions used in the framework.

It should have a Page object repository for all pages.
 
## 2. Must be Flexible
Having parameters in your framework gives more control to the user to determine which scenarios they would like to run. This is useful if they identify a potential bug in the system that might have been overlooked. This diminishes the pesticide paradox to a certain degree.
 
## 3. Must be easy to understand
A framework that is easy to understand, intuitive and has comments assists in making maintenance easier.
 
## 4. Must be Reliable
The results of the testcases should be reliable i.e. there should be no doubt that a passed testcase is a false positive.

## 5. Must have good Reporting
Without reporting the framework will be useless. Stakeholders need to know which tests have passed and failed in order for the framework to add value. It is also useful to have a dashboard that someone can have a quick look at to determine the quality of the system under test e.g. Jenkins.
Good reporting also assists in debugging by localising the point of failure which can save time in identifying the cause of failure.
