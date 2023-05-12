Feature: 3 Delete

@tag3
Scenario: Delete file from dropbox
	Given I check if file exists for delete
	When I delete file from dropbox
	Then I should get delete success status code