// This file can be replaced during build by using the `fileReplacements` array.
// `ng build` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

import { EnvironmentConfiguration } from "../app/models/environment-configuration";


const serverUrl='https://localhost:7005/api';


// The list of file replacements can be found in `angular.json`.
export const environment: EnvironmentConfiguration = {
  env_name: 'dev',
  production: true,
  apiUrl: serverUrl,
  apiEndpoints: {
    userProfile:'user-profiles'
  },
  adb2cConfig: {
    chatHubUrl: 'https://localhost:7005/chathub', 
    clientId: '5212f2c7-60a9-46ad-bcbb-3f5dc9af3dab',
    readScopeUrl: '',
    writeScopeUrl: '',
    scopeUrls:[
      '',
        ],
    apiEndpointUrl: 'https://localhost:7005/api'
  },
  cacheTimeInMinutes: 30,
};
