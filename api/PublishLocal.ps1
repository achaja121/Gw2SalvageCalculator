$projectPath = $PSScriptRoot + '\Gw2SalvageCalculatorApi.sln'
$publishProfile = $PSScriptRoot + '\src\Properties\PublishProfiles\FolderProfile.pubxml'
$msBuild = "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe"
$steps = 3

function Write-ProgressHelper {
	param (
	    [int]$StepNumber,
	    [string]$Message
	)

	Write-Progress -Activity 'Title' -Status $Message -PercentComplete (($StepNumber / $steps) * 100)
}

Write-ProgressHelper -Message 'Stopping services before publish' -StepNumber (1)
Stop-Service -Name was,w3svc -PassThru

Write-ProgressHelper -Message 'Publishing' -StepNumber (2)

& $msBuild $projectPath /p:DeployOnBuild=true /p:PublishProfile=$publishProfile

Write-ProgressHelper -Message 'Staring services' -StepNumber (3)
Start-Service -name was,w3svc -PassThru