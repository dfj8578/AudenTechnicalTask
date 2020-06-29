Feature: HmpageFeature
	

@audentestpratical
Scenario: Apply for Monthly loan Instalment
	Given I am on Auden homepage and select Loan Amount and Repayment day
	Then i should see the First repayment date text as 'Friday 24 Jul 2020'
	And i should see the The min as 200 and Max as 500
	And i should see the The minandmax amount'
	And The selected slider amount is Loan amount
	