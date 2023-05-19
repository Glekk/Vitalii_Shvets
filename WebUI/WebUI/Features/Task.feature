Feature: Task

@mytag
Scenario: Add, delete job
	Given I am logging in
	And I go to Admin page
	And I go to Job Titles page
	When I clck on the Add button
	And I fill out the form
	Then I see the job is added
	And I click on the delete button
	And I see the job is deleted