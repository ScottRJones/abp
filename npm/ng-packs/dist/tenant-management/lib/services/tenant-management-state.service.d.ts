import { Store } from '@ngxs/store';
export declare class TenantManagementStateService {
    private store;
    constructor(store: Store);
    getTenants(): import("@abp/ng.core").ABP.BasicItem[];
    getTenantsTotalCount(): number;
}
