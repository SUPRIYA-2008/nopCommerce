pipeline {
    agent { label 'DOTNET-7' }
    triggers {
         pollSCM('* * * * *')
    }
    tools {
        jdk 'jdk-17' 
    }
    stages { 
        stage('git clone') {
            steps {
                git branch: 'develop',
                    url: 'https://github.com/SUPRIYA-2008/nopCommerce.git'   
            }
        }
        stage('restore and build') {
            steps {
                sh '''dotnet restore src/NopCommerce.sln'
                   'dotnet build -c Release src/NopCommerce.sln'''
            }
        }       
    }
}    