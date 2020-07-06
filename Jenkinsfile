pipeline {
    agent any
    stages {
        stage('Export features from Xray'){
            steps {
                checkout([$class: 'GitSCM', branches: [[name: '*/xray_test']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[credentialsId: '4ec75a0e-3ea4-4576-a0d6-fdbcd1c1fbb2', url: 'https://github.com/TaiCeline/JenkinsTests.git']]])
                step([$class: 'XrayExportBuilder', filePath: 'cucumber_xray_tests/features', filter: '10001', serverInstance: '4ec75a0e-3ea4-4576-a0d6-fdbcd1c1fbb2'])
            }
        }
         
        stage('Test'){
            steps{
                sh "cd cucumber_xray_tests && cucumber -x -f json -o data.json"
            }
        }
         
        stage('Import results to Xray') {
            steps {
                step([$class: 'XrayImportBuilder', endpointName: '/cucumber', importFilePath: 'cucumber_xray_tests/data.json', serverInstance: '4ec75a0e-3ea4-4576-a0d6-fdbcd1c1fbb2'])
            }
        }
    }
}