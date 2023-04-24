package net.fodev.foclassic;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.attribute.BasicFileAttributes;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class Cleaner {
    private List<String> paths;
    private enum Mode {
        SCRIPT, MAP, BOTH
    }
    private Mode mode;

    public Cleaner(List<String> paths, String mode) {
        this.paths = paths;
        switch (mode) {
            case "script":
            case "SCRIPT":
            case "scripts":
            case "SCRIPTS":
                this.mode = Mode.SCRIPT;
                break;
            case "map":
            case "MAP":
            case "maps":
            case "MAPS":
                this.mode = Mode.MAP;
                break;
            default:
                this.mode = Mode.BOTH;
        }
    }

    public void clean() {
        System.out.println("Cleaning up binaries of modified files:");
        for (String path: paths) {
            Path folder = Paths.get(path);
            if (Files.exists(folder)) {
                System.out.println("\t" + path);
                try {
                    if (mode == Mode.SCRIPT || mode == Mode.BOTH) {
                        List<String> files = findFiles(folder,"fos");
                        //files.forEach(System.out::println);
                        files.forEach(this::clearSourceBinaries);
                    }
                    if (mode == Mode.MAP || mode == Mode.BOTH) {
                        List<String> files = findFiles(folder,"fomap");
                        //files.forEach(System.out::println);
                        files.forEach(this::clearMapBinaries);
                    }
                } catch (IOException e) {
                    throw new RuntimeException(e);
                }

            } else {
                System.out.println("Warning: Folder doesn't exist! [" + folder + "]");
            }
        }
    }

    public List<String> findFiles(Path path, String fileExtension)
            throws IOException {

        if (!Files.isDirectory(path)) {
            throw new IllegalArgumentException("Path must be directory!");
        }

        List<String> result;

        try (Stream<Path> walk = Files.walk(path)) {
            result = walk.filter(p -> !Files.isDirectory(p))
                    .map(p -> p.toString().toLowerCase())
                    .filter(f -> f.endsWith(fileExtension))
                    .collect(Collectors.toList());
        }
        return result;
    }

    public List<String> getBinaryFiles(String source) {
        List<String> result = new ArrayList<>();
        result.add(source + "b");
        result.add(source + "p");
        return result;
    }

    public void clearSourceBinaries(String source) {
        try {
            List<String> binaries = getBinaryFiles(source);
            Path sourceFile = Paths.get(source);
            BasicFileAttributes srcAttr = Files.readAttributes(sourceFile, BasicFileAttributes.class);

            Path bFile = Paths.get(binaries.get(0));
            if (Files.exists(bFile)) {
                BasicFileAttributes bAttr = Files.readAttributes(bFile, BasicFileAttributes.class);
                if (srcAttr.lastModifiedTime().toMillis() > bAttr.lastModifiedTime().toMillis()) {
                    //System.out.println(String.format("\tNewer source found: %s %s\t\t- %s %s", sourceFile.getFileName(), srcAttr.lastModifiedTime().toString(), bFile.getFileName(), bAttr.lastModifiedTime().toString()));
                    System.out.println(String.format("\t\tdeleting: %s (%s > %s)", bFile.getFileName(), srcAttr.lastModifiedTime().toString(), bAttr.lastModifiedTime().toString()));
                    Files.deleteIfExists(bFile);
                }
            }

            Path pFile = Paths.get(binaries.get(1));
            if (Files.exists(pFile)) {
                BasicFileAttributes pAttr = Files.readAttributes(pFile, BasicFileAttributes.class);
                if (srcAttr.lastModifiedTime().toMillis() > pAttr.lastModifiedTime().toMillis()) {
                    //System.out.println(String.format("\tNewer source found: %s %s\t\t- %s %s", sourceFile.getFileName(), srcAttr.lastModifiedTime().toString(), pFile.getFileName(), pAttr.lastModifiedTime().toString()));
                    System.out.println(String.format("\t\tdeleting: %s (%s > %s)", pFile.getFileName(), srcAttr.lastModifiedTime().toString(), pAttr.lastModifiedTime().toString()));
                    Files.deleteIfExists(pFile);
                }
            }
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }

    public void clearMapBinaries(String source) {
        try {
            String binary = source + "b";
            Path sourceFile = Paths.get(source);
            BasicFileAttributes srcAttr = Files.readAttributes(sourceFile, BasicFileAttributes.class);

            Path bFile = Paths.get(binary);
            if (Files.exists(bFile)) {
                BasicFileAttributes bAttr = Files.readAttributes(bFile, BasicFileAttributes.class);
                if (srcAttr.lastModifiedTime().toMillis() > bAttr.lastModifiedTime().toMillis()) {
                    //System.out.println(String.format("\tNewer source found: %s %s\t\t- %s %s", sourceFile.getFileName(), srcAttr.lastModifiedTime().toString(), bFile.getFileName(), bAttr.lastModifiedTime().toString()));
                    System.out.println(String.format("\t\tdeleting: %s (%s > %s)", bFile.getFileName(), srcAttr.lastModifiedTime().toString(), bAttr.lastModifiedTime().toString()));
                    Files.deleteIfExists(bFile);
                }
            }
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
}

