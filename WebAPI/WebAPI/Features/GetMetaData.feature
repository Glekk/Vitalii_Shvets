Feature: 2 GetMetaData

@tag2
Scenario: Get file metadata from dropbox
	Given I check if file exists to get metadata
	When I get the file metadata
	Then I should get metadata success status code