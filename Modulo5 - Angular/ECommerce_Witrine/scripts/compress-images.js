/*
 Image compression script using sharp.
 - Reads images from src/assets (jpg, jpeg, png)
 - Writes optimized images to src/assets/optimized

 Usage:
 1. npm install sharp --save-dev
 2. npm run compress-images

 The script is intentionally simple and idempotent. It keeps original filenames and writes to 'optimized' subfolder.
*/

const fs = require('fs');
const path = require('path');

async function main() {
  const sharpAvailable = checkSharp();
  if (!sharpAvailable) {
    console.error('\nError: the package "sharp" is not installed.');
    console.error('Install it by running: npm install sharp --save-dev\n');
    process.exit(1);
  }

  const sharp = require('sharp');
  const assetsDir = path.resolve(__dirname, '..', 'src', 'assets');
  const outDir = path.join(assetsDir, 'optimized');

  if (!fs.existsSync(assetsDir)) {
    console.error('Assets folder not found at', assetsDir);
    process.exit(1);
  }

  if (!fs.existsSync(outDir)) {
    fs.mkdirSync(outDir, { recursive: true });
  }

  const entries = fs.readdirSync(assetsDir);
  const images = entries.filter(f => /Capa_|Logo_|\.jpe?g$|\.png$/i.test(f));

  if (images.length === 0) {
    console.log('No images found to compress in', assetsDir);
    return;
  }

  console.log('Found images:', images.join(', '));

  for (const file of images) {
    const srcPath = path.join(assetsDir, file);
    const ext = path.extname(file).toLowerCase();
    const baseName = path.basename(file);
    const destPath = path.join(outDir, baseName);

    try {
      if (ext === '.jpg' || ext === '.jpeg') {
        await sharp(srcPath)
          .jpeg({ quality: 75, mozjpeg: true })
          .toFile(destPath);
      } else if (ext === '.png') {
        // For PNG use a fast palette reduction and compression
        await sharp(srcPath)
          .png({ compressionLevel: 8, palette: true })
          .toFile(destPath);
      } else {
        // Copy other files as-is
        fs.copyFileSync(srcPath, destPath);
      }
      const srcSize = fs.statSync(srcPath).size;
      const destSize = fs.statSync(destPath).size;
      const saved = ((srcSize - destSize) / srcSize) * 100;
      console.log(`Compressed ${file}: ${formatBytes(srcSize)} -> ${formatBytes(destSize)} (${saved.toFixed(1)}% saved)`);
    } catch (err) {
      console.error('Failed to process', file, err.message || err);
    }
  }

  console.log('\nOptimized images written to:', outDir);
}

function checkSharp() {
  try {
    require.resolve('sharp');
    return true;
  } catch (err) {
    return false;
  }
}

function formatBytes(bytes, decimals = 1) {
  if (bytes === 0) return '0 B';
  const k = 1024;
  const dm = decimals < 0 ? 0 : decimals;
  const sizes = ['B', 'KB', 'MB', 'GB', 'TB'];
  const i = Math.floor(Math.log(bytes) / Math.log(k));
  return parseFloat((bytes / Math.pow(k, i)).toFixed(dm)) + ' ' + sizes[i];
}

main().catch(err => {
  console.error(err);
  process.exit(1);
});
