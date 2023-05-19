Feature: Upload

@upload
Scenario: Upload file to dropbox
	When I upload the file
	Then I should see the file in the dropbox