Feature: Registration
	Testing register new account

@RegisterSuccessful
Scenario: User successfully creates a new account
	Given Elsa is on Buggy car App Registration page
	And fill username lui000
	And fill firstname Elsa 
	And fill lastname Lui
	And set password Elsa1234%
	And set confirm password Elsa1234%
	When click on Register button by valid details
	Then see prompt message: Registration is successful