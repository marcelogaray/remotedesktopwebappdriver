Feature: RemoteDesktopAppFeature
Validate that the following scenarios

Scenario Outline: Verify All Scenarios
	# Scenario 1
	Given I launch Remote DesktopApp 
	Then The title bar should be diplayed
		And the "Remote Desktop" title bar contains the text
		And the "<Content Title>" text is displayed
		And the "<Description>" text is displayed
	# Scenario 2
	When I click 'Add' button in the header
	Then the Scroll Viewer panel is displayed
		And the 'Desktop' button is shown
		And the "Desktop" text is displayed
		And the "<Content Desktop button>" text is displayed
	When I click 'Desktop' button in the 'Choose what to add' scroll viewer
	Then the "Add a desktop" text is displayed
		And the PC Name input is shown
		And the User account combobox  is show
		And the Display name field is show
	# Scenario 3
	When I double click 'Settings' button in the header
		And I click + icon available for User account
		And I fill "<Username>" username textbox
		And I fill "<Password>" password textbox
		And I fill "<Display>" display name textbox
		And I click 'Save' button 
	Then the "<Username>" should be showed in the item of 'User account' combobox
	Examples: 
	    | Content Title				   | Description | Content Desktop button | Username | Password | Display | 
		| Connect to apps and desktops | To get started, add a remote PC you want to connect to using this device. You can also add remote resources to work with apps and desktops someone has set up for you. | Connect to a PC        |  Test     | Test     | Test | 




#Scenario Outline: Verify that Remote Desktop Application is displayed
#	Given I launch Remote DesktopApp 
#	Then The title bar should be diplayed
#		And the "Remote Desktop" title bar contains the text
#		And the "<Content Title>" text is displayed
#		And the "<Description>" text is displayed
#	Examples: 
#	    | Content Title					   | Description |
#		| Connect to apps and desktops | To get started, add a remote PC you want to connect to using this device. You can also add remote resources to work with apps and desktops someone has set up for you. |


#Scenario Outline: Verify that Click the add button and validate that "Desktop" option can be clicked
#	Given I launch Remote DesktopApp 
#	When I click 'Add' button in the header
#	Then the Scroll Viewer panel is displayed
#		And the 'Desktop' button is shown
#		And the "Desktop" text is displayed
#		And the "<Content Desktop button>" text is displayed
#	When I click 'Desktop' button in the 'Choose what to add' scroll viewer
#	Then the "Add a desktop" text is displayed
#		And the PC Name input is shown
#		And the User account combobox  is show
#		And the Display name field is show
#	Examples: 
#	    | Content Desktop button | 
#		| Connect to a PC        | 


#Scenario Outline: Verify that an account can be added through the settings section
#	Given I launch Remote DesktopApp 
#   When I click 'Settings' button in the header
#		And I click + icon available for User account
#		And I fill "<Username>" username textbox
#		And I fill "<Password>" password textbox
#		And I fill "<Display>" display name textbox
#		And I click 'Save' button 
#	Then the "<Username>" should be showed in the item of 'User account' combobox
#	Examples: 
#	    | Username | Password | Display | 
#		| Test     | Test     | Test | 