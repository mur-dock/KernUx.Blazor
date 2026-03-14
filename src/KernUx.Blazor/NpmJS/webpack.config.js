const path = require("path");
module.exports = {
    mode: "production",
    entry: "./src/index.js",
    output: {
        path: path.resolve(__dirname, "..", "wwwroot", "js"),
        filename: "index.bundle.js",
    },
    optimization: {
        splitChunks: false,
        runtimeChunk: false,
    },
    performance: {
        // Single-Bundle ist hier bewusst gewollt; daher höhere Grenzwerte statt Default-244-KiB.
        hints: "warning",
        maxAssetSize: 2 * 1024 * 1024,
        maxEntrypointSize: 2 * 1024 * 1024,
    },
    module: {
        parser: {
            javascript: {
                // Stencil-Loader nutzt import(); mit eager bleibt alles in einer Bundle-Datei.
                dynamicImportMode: "eager",
            },
        },
    },
};