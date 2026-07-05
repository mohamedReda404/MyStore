import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44336/',
  redirectUri: baseUrl,
  clientId: 'AppStore_App',
  responseType: 'code',
  scope: 'offline_access AppStore',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'AppStore',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44336',
      rootNamespace: 'AppStore',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
