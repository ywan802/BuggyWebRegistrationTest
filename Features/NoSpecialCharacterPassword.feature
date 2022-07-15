Feature: NoSpecialCharacterPassword
	Testing wrong password format which without Special Character

@NoSpecialCharacterPasswrod
Scenario: wrong password without special characters
	Given Jay is on Buggy car App Registration page
	And fill username jay007
	And fill firstname Jay
	And fill lastname Blue
	And set password JAYjay123 
	And set confirm password JAYjay123 
	When click Register button by valid password
	Then see an error message: InvalidPasswordException



