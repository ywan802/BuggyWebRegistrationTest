Feature: DuplicatedUsername
	register an existing account with username lee123

@DuplicatedAccountRegister
Scenario: User can only register once
	Given Alice is on Buggy car App Registration page
	And fill duplicated username lee123
	And fill firstname Alice
	And fill lastname Lee
	And set password Alice123%  
	And set confirm password Alice123%  
	When click Register button by duplicated username
	Then see an error prompt message: UsernameExistsException: User already exists