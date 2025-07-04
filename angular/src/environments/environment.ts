 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44311/',
  redirectUri: baseUrl,
  clientId: 'InstrumentalHub_App',
  responseType: 'code',
  scope: 'offline_access InstrumentalHub',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'InstrumentalHub',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44311',
      rootNamespace: 'InstrumentalHub',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
