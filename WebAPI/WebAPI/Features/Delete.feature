Feature: Delete

@delete
Scenario: Delete file from dropbox
	Given I check if file exists for delete
	When I delete file from dropbox
	Then I should not see the file in dropbox