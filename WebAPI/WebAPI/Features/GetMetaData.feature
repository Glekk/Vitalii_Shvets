Feature: GetMetaData

@getmetadata
Scenario: Get file metadata from dropbox
	Given I check if file exists to get metadata
	When I get the file metadata
	Then I should get metadata