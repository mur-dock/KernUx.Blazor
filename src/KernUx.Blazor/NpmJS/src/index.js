import { register } from "@public-ui/components";
import { defineCustomElements } from "@public-ui/components/dist/loader";
import { KERN_V2 } from '@kern-ux-public-ui/theme-kolibri';

register(KERN_V2, defineCustomElements).then(() => {
    if (Blazor) {
        Blazor.start();
    } else {
        console.warn("Unable to start Blazor. Is it not initialized?");
    }
});

