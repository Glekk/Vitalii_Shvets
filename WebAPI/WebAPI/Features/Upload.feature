Feature: 1 Upload

@tag1
Scenario: Upload file to dropbox
	Given I check if the file exists for upload
	When I upload the file
	Then I should get upload success status code