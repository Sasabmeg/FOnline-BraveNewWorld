package net.fodev.foclassic;

import net.sourceforge.argparse4j.ArgumentParsers;
import net.sourceforge.argparse4j.inf.ArgumentParser;
import net.sourceforge.argparse4j.inf.ArgumentParserException;
import net.sourceforge.argparse4j.inf.Namespace;

import java.util.List;


public class Main {
    public static void main(String[] args) {
        System.out.println("Fallout Online Classic - Cleaning Tool");
        ArgumentParser argumentParser;
        argumentParser = setupArguments();

        Namespace ns = null;
        try {
            ns = argumentParser.parseArgs(args);
        } catch (ArgumentParserException e) {
            argumentParser.handleError(e);
            System.exit(1);
        }

        String mode = ns.getString("mode");
        if ("script".equalsIgnoreCase(mode) || "map".equalsIgnoreCase(mode) || "both".equalsIgnoreCase(mode)
            || "scripts".equalsIgnoreCase(mode) || "maps".equalsIgnoreCase(mode)) {
            System.out.println("Mode: " + mode);
        } else {
            System.err.println("Invalid mode!");
            System.exit(1);
        }

        List<String> inputFolders = ns.getList("directories");
        if (inputFolders == null) {
            System.err.println("Missing input folders");
            System.exit(1);
        } else {
            System.out.println("Folders:");
            inputFolders.forEach(f -> System.out.println("\t" + f));
        }

        Cleaner cleaner = new Cleaner(inputFolders, mode);
        cleaner.clean();
    }

    private static ArgumentParser setupArguments() {
        ArgumentParser argumentParser;
        argumentParser = ArgumentParsers.newFor("foclassic-cleaning-tool").build()
                .defaultHelp(true)
                .description("Fallout Online Classic - Cleaning Tool. " +
                        "Cleans older Angel Script source binaries or map binaries based on parameters.");
        argumentParser.addArgument("-m", "--mode")
                .choices("script", "map", "both").setDefault("both")
                .help("Choose 'mode' to clean map, script binaries or both");
        argumentParser.addArgument("-d", "--directories").nargs("*")
                .help("Specify the location of the files.");
        return argumentParser;
    }
}