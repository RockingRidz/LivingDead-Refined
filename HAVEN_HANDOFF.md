# Status
This is a modified source project, NOT a playable WebGL build. No index.html has been fabricated.
Original ZIP untouched. Library, Temp, Logs, obj, UserSettings and .git caches excluded from this copy.

## Changes
- EnemyController: restored the attack cooldown; previously a projectile could spawn every rendered frame.
- Zombie controller: reuse the player lookup, guard missing player, and prevent queuing a new ten-second patrol callback every frame.
- Added Haven > Build itch WebGL menu. Preserves enabled scene order and configures Gzip plus decompression fallback.
Changes have not been compiled or play-tested. Building appearance has not been changed.

## Finish
1. Install Unity 2020.3.24f1 with WebGL Build Support through Unity Hub (the project's recorded version). Current installed Unity 6 lacks WebGL support; avoid upgrading this old project during the deadline.
2. Open this folder through Unity Hub and allow import. Resolve any Console errors.
3. Play the game and verify firing rates, zombie patrol, scene transitions and controls.
4. Choose Haven > Build itch WebGL. Output: Builds/itch-web.
5. ZIP that folder's CONTENTS, with index.html directly at ZIP root, together with Build and TemplateData.
6. Upload on itch as HTML; mark playable in browser. Test the draft including mouse capture, sound and scene transitions before publishing.
7. If the actual WebGL output exceeds 1 GB, inspect its Build Report. Reduce the largest referenced textures/audio first; don't delete build files.

## Attribution
Preserve the original README and original author credits. Its README states some third-party asset sources are unknown; this copy does not establish redistribution rights for those assets. Describe the work as a modification of Living Dead, not an original game made entirely by this team.
