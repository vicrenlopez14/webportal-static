import 'package:fluent_ui/fluent_ui.dart';
import 'package:flutter/material.dart';
import 'package:profindweb/ui/Access.dart';
import 'package:profindweb/ui/Catalog.dart';
import 'package:profindweb/ui/HomePage.dart';
import 'package:url_launcher/url_launcher.dart';

const String routeHome = '/';
const String routeLandingPage = 'landing-page';
const String routeCatalog = 'catalog';
const String routeLandingPageSpanish = '$routeLandingPage/es';
const String routeLandingPageEnglish = '$routeLandingPage/en';
const String routeAccess = 'access';

final navKey = new GlobalKey<NavigatorState>();

class RouteGenerator {
  static Route<dynamic> generateRoute(RouteSettings settings) {
    switch (settings.name) {
      case routeHome:
        return MaterialPageRoute(builder: (_) => HomePage());
      case routeLandingPageEnglish:
        _launchLandingPageURL('es');
        break;
      case routeLandingPageSpanish:
        _launchLandingPageURL('en');
        break;
      case routeAccess:
        return MaterialPageRoute(builder: (_) => AccessPage());
      case routeCatalog:
        return MaterialPageRoute(builder: (_) => CatalogPage());

      default:
        return MaterialPageRoute(
            builder: (_) => Scaffold(
                  body: Center(
                    child: Text('No page defined for ${settings.name}'),
                  ),
                ));
    }
    return MaterialPageRoute(
      builder: (_) => Scaffold(
        body: Center(
          child: Text('No page defined for ${settings.name}'),
        ),
      ),
    );
  }
}

// Function to redirect to the landing page
void _launchLandingPageURL(String language) async {
  final toLaunchUri =
      Uri.parse("https://github.com/vicrenlopez14/profind-landing-page");
  await canLaunchUrl(toLaunchUri)
      ? await launchUrl(toLaunchUri, mode: LaunchMode.externalApplication)
      : throw 'Could not launch $routeLandingPage';
}
